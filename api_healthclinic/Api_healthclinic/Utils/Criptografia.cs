namespace Api_healthclinic.Utils
{
    public static class Criptografia
    {
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

       public static bool CompararHash(string SenhaForm,String SenhaBanco )
       {
         return BCrypt.Net.BCrypt.Verify(SenhaForm,SenhaBanco);
       }

    }

}
