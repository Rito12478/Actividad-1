namespace Actividad_1
{
    class Adopcion
    {

        private string IdAdopcion;
        public Usuario _usuario;
        public Mascota _mascota;
        private string NombreMascota;
        private string Fecha;
        private string Sucursal;

        public void Transaccion(Mascota mascota, Usuario usuario){
            this._usuario = usuario;
            this._mascota =  mascota;
        }
        
    }
}
