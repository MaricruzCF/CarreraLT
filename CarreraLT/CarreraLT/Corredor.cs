using System;
namespace CarreraLT
{
    abstract class Corredor
    {
        protected int _pasos;
        public int Pasos { get{ return _pasos; } }
        protected static Random rnd = new Random(DateTime.Now.Millisecond);

        public Corredor()
        {
            _pasos = 0;
        }

        public abstract void Avanzar();

        public override string ToString()
        {
            return "A dado" + _pasos;
        }
    }
}
