namespace IST.RRHH.Model
{
    using IST.RRHH.Model.DataBase;

    public partial class Context : Entities, IBDContext
    {
        public Context()
        {

        }
        public Context(string connString) : base(connString)
        {

        }
    }
}