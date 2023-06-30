using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastaloni.Model.DataAccess
{
    public class User
    {
        public static List<DTO.User> returnsUsers()
        {
            List<DTO.User> list = new List<DTO.User>()
            {
                new DTO.User()      {
                                    Name="Lucas",
                                    Surname="Cofre",
                                    Dni="39123467",
                                    Email="cofre.le@gmail.com",
                                    Password="123123",
                                    Address="Garay 5399",
                                    Roles   =   new List<DTO.Roles>(){
                                                                        new DTO.Roles() 
                                                                        {
                                                                                                Id = 1,
                                                                                                RoleName = "Admin",
                                                                                                Menus = new List<DTO.Menu>() 
                                                                                                {  new DTO.Menu()
                                                                                                        {
                                                                                                             id = 1,
                                                                                                             MenuName = "Ventas"
                                                                                                        },
                                                                                                        new DTO.Menu()
                                                                                                        {
                                                                                                             id = 2,
                                                                                                             MenuName = "Deposito"
                                                                                                        },
                                                                                                        new DTO.Menu()
                                                                                                        {
                                                                                                             id = 3,
                                                                                                             MenuName = "Admin"
                                                                                                        }
                                                                                                }
                                                                        }
                                    },
                },
                new DTO.User()      {
                                    Name="Nicolas",
                                    Surname="Cofre",
                                    Dni="35833583",
                                    Email="nikaonob@gmail.com",
                                    Password="123123",
                                    Address="Curupaity 5825",
                                    Roles   =   new List<DTO.Roles>(){
                                                                        new DTO.Roles() {
                                                                                            Id = 1,
                                                                                            RoleName = "Vendedor",
                                                                                            Menus = new List<DTO.Menu>() 
                                                                                            {  new DTO.Menu()
                                                                                                    {
                                                                                                         id = 1,
                                                                                                         MenuName = "Ventas"
                                                                                                    }
                                                                                            }
                                                                        }
                                    },
                },
                new DTO.User()      {
                                    Name="Daiana",
                                    Surname="Cofre",
                                    Dni="38899508",
                                    Email="cofredaiana@gmail.com",
                                    Password="123123",
                                    Address="Apipe 7847",
                                    Roles   =   new List<DTO.Roles>(){
                                                                        new DTO.Roles() {
                                                                                            Id = 1,
                                                                                            RoleName = "Otro",
                                                                                            Menus = new List<DTO.Menu>() 
                                                                                            {  new DTO.Menu()
                                                                                                    {
                                                                                                         id = 1,
                                                                                                         MenuName = "Ventas"
                                                                                                    },
                                                                                                    new DTO.Menu()
                                                                                                    {
                                                                                                         id = 2,
                                                                                                         MenuName = "Deposito"
                                                                                                    }
                                                                                            }
                                                                        }
                                    },
                },
                new DTO.User()      {
                                    Name="Nelida",
                                    Surname="Borraz",
                                    Dni="33231232",
                                    Email="elyborraz33@gmail.com",
                                    Password="123123",
                                    Address="Ferran 456",
                                    Roles   =   new List<DTO.Roles>(){
                                                                        new DTO.Roles() {
                                                                                            Id = 1,
                                                                                            RoleName = "Deposito",
                                                                                            Menus = new List<DTO.Menu>()
                                                                                            {  new DTO.Menu()
                                                                                                    {
                                                                                                         id = 2,
                                                                                                         MenuName = "Deposito"
                                                                                                    }
                                                                                            }
                                                                        }
                                    },
                }
            };
            return list;
        }
    }
}
