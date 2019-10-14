namespace AdapterSample
{
    class DrivablePlane : ICar
    {
        private Plane plane;

        public DrivablePlane()
        {
            plane = new Plane();
        }

        public void Drive()
        {
            plane.Fly();
        }
    }
}
