namespace Pringles.Utilities.Consts
{
    /// <summary>
    /// Tabla con los codigo del sistema.
    /// </summary>
    public static class UserRoles
    {
        public const int ADMIN = 1;
        public const string ADMIN_DESCRIPCION = "Administrador del sistema";

        public const int GERENTE_ALMACEN = 2;
        public const string GERENTE_ALMACEN_DESCRIPCION = "Gerente del almacen";

        public const int GERENTE_TECNOLOGIA = 3;
        public const string GERENTE_TECNOLOGIA_DESCRIPCION = "Gerente de tecnologia";

        public const int GERENTE_VENTAS = 4;
        public const string GERENTE_VENTAS_DESCRIPCION = "Gerente de ventas";

        public const int CAJERO = 5;
        public const string CAJERO_DESCRIPCION = "Cajero";
    }
}
