using HelixToolkit.Wpf;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace Flight_Inspection_App.Controls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MultiDimensionalModel : UserControl
    {
        public MultiDimensionalModel()
        {
            InitializeComponent();
            Create3DViewPort();

        }
        private void Create3DViewPort()
        {

            ObjReader CurrentHelixObjReader = new ObjReader();
            Model3DGroup MyView = CurrentHelixObjReader.Read(@"..\..\..\3D planes\Black Hawk uh-60.obj");
            myView.Camera.LookDirection = new Vector3D(0, -1, 0);
            model.Content = MyView;



        }
    }
}
