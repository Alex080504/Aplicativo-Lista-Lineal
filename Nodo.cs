namespace Aplicativo.Lista.Circular
{
    public class Nodo
    {
        private object info;
        private Nodo siguiente { get; set; }
        public Nodo(object info)
        {
            this.info = info;
            this.siguiente = null;
        }
        public object Info
        {
            get { return info; }
            set { info = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
