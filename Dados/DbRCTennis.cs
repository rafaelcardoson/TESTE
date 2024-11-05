using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using RCTENNIS.Dados;




namespace RCTENNIS.Dados
{
    public class DbRCTennis : DbContext
    {
        string sqlcon = "";
        public DbRCTennis(string dbcon)
        {
            sqlcon = "Connnectionstrings:" + dbcon;
        }
       

        public DbSet<TAB_EMPRESA> TAB_EMPRESAs { get; set; }
        


    }
}
