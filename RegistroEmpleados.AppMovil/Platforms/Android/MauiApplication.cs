using Android.Runtime;

namespace RegistroEmpleados.AppMovil
{
    public class MauiApplication
    {
        private nint handle;
        private JniHandleOwnership ownership;

        public MauiApplication(nint handle, JniHandleOwnership ownership)
        {
            this.handle = handle;
            this.ownership = ownership;
        }

        protected override MauiApp CreateMauiApp => MauiProgram.CreateMauiApp();
    }
}