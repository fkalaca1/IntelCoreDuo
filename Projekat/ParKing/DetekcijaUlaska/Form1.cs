using System;
using System.Drawing;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;

namespace DetekcijaUlaska
{
    public partial class Form1 : Form
    {
        public static int brojac = 0;
        private OzekiCamera _camera;
        private DrawingImageProvider _provider;
        private MediaConnector _connector;

        private Tripwire tripwire;
        private Tripwire tripwire2;

        private Point _p1, _p2;
        private CameraURLBuilderWF _myCameraUrlBuilder;

        public Form1()
        {
            InitializeComponent();

            tripwire = new Tripwire();
            tripwire2 = new Tripwire();
            _myCameraUrlBuilder = new CameraURLBuilderWF();
            _provider = new DrawingImageProvider();
            _connector = new MediaConnector();
            videoViewerWF1.SetImageProvider(_provider);
        }

        private void startBt_Click(object sender, EventArgs e)
        {
            if (_camera == null) return;
            tripwire.Line.LineWidth = 3;
            tripwire.LineColor = Color.Red;

            //tripwire2.Line.LineWidth = 4;
            //tripwire2.LineColor = Color.Green;

            tripwire.SetPoints(new Point(450, 200), new Point(350, 200));
            tripwire.HighlightMotion = HighlightMotion.Highlight;

            //tripwire2.SetPoints(new Point(309, 109), new Point(250, 309));
            //tripwire2.HighlightMotion = HighlightMotion.Highlight;

            tripwire.MotionColor = Color.Blue;
            tripwire.TripwireMotionEnteredToLine += TripwireMotionEnteredToLine;
            tripwire.TripwireMotionLeaveFromLine += TripwireMotionLeaveFromLine;

            //tripwire2.MotionColor = Color.Orange;
            //tripwire2.TripwireMotionEnteredToLine += TripwireMotionEnteredToLine;
            //tripwire2.TripwireMotionLeaveFromLine += TripwireMotionLeaveFromLine;

            tripwire.Start();
            //tripwire2.Start();
        }

        private void stopBt_Click(object sender, EventArgs e)
        {
            tripwire.Stop();
            //tripwire2.Stop();
        }

        void InvokeThread(Action action)
        {
            Invoke(action);
        }

        void TripwireMotionLeaveFromLine(object sender, TripwireMotionCrossedArgs e)
        {
            brojac++;
            InvokeThread(() => { crossedText.Text = brojac.ToString(); });
        }

        void TripwireMotionEnteredToLine(object sender, TripwireMotionCrossedArgs e)
        {
            InvokeThread(() => { crossedText.Text = @"ENTER!!!"; });
        }

        private void videoViewerWF1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _p1 = e.Location;
            videoViewerWF1.MouseMove += videoViewerWF1_MouseMove;
        }

        private void videoViewerWF1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _p2 = e.Location;
            tripwire.SetPoints(_p1, _p2);
            videoViewerWF1.MouseMove -= videoViewerWF1_MouseMove;
        }

        private void videoViewerWF1_MouseMove(object sender, MouseEventArgs e)
        {
            _p2 = e.Location;
            tripwire.SetPoints(_p1, _p2);
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (_camera != null)
            {
                _camera.CameraStateChanged -= _camera_CameraStateChanged;
                _camera.Disconnect();
                _connector.Disconnect(_camera.VideoChannel, _provider);
                _camera.Dispose();
                _camera = null;
            }

            _camera = new OzekiCamera(_myCameraUrlBuilder.CameraURL);
            _camera.CameraStateChanged += _camera_CameraStateChanged;

            _connector.Connect(_camera.VideoChannel, tripwire);
            _connector.Connect(tripwire, _provider);

            //upitno
            //_connector.Connect(_camera.VideoChannel, tripwire2);
            //_connector.Connect(tripwire2, _provider);
            //upitno
            _camera.Start();

            videoViewerWF1.Start();
        }

        private void _camera_CameraStateChanged(object sender, CameraStateEventArgs e)
        {
            InvokeThread(() =>
            {
                if (e.State == CameraState.Connecting)
                    button_Connect.Enabled = false;
                if (e.State == CameraState.Streaming)
                    button_Disconnect.Enabled = true;
                if (e.State == CameraState.Disconnected)
                {
                    button_Disconnect.Enabled = false;
                    button_Connect.Enabled = true;
                }

                stateLabel.Text = e.State.ToString();
            });
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            if (_camera == null) return;

            _camera.Disconnect();
            _camera.Stop();
            _camera = null;
            videoViewerWF1.Stop();
        }

        private void button_Compose_Click(object sender, EventArgs e)
        {
            var result = _myCameraUrlBuilder.ShowDialog();

            if (result != DialogResult.OK) return;

            tb_cameraUrl.Text = _myCameraUrlBuilder.CameraURL;

            button_Connect.Enabled = true;
        }
    }
}

