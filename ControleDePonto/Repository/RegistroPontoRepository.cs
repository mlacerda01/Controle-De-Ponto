using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ControleDePonto.Models;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace ControleDePonto.Repository
{
    public class RegistroPontoRepository : IRegistroPontoRepository
    {
        IConfiguration _configuration;

        public RegistroPontoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("ConexaoDB").Value;
            return connection;
        }

        public int Add(RegistroPonto registro)
        {
            int codRetorno = 0;
            string connection = this.GetConnection();

            using(var con = new SqlConnection(connection))
            {
                string sql = @"Insert into RegistroPonto 
                               ( 
                                    CodUsuario,
                                    Date, 
                                    HoraEntrada, 
                                    HoraSaidaAlmoco, 
                                    HoraRetornoAlmoco, 
                                    HoraSaida, 
                                    TotalHoras, 
                                    DescricaoAtividades
                                )
                                values
                                ( 
                                    @CodUsuario,
                                    @Date, 
                                    @HoraEntrada, 
                                    @HoraSaidaAlmoco, 
                                    @HoraRetornoAlmoco, 
                                    @HoraSaida, 
                                    @TotalHoras, 
                                    @DescricaoAtividades
                                );

                        SELECT CAST(SCOPE_IDENTITY() as INT);
                ";

                codRetorno = con.Execute(sql, registro);

            }

            return codRetorno;
        }

        public int Delete(int id)
        {
            int codRetorno = 0;
            string connection = this.GetConnection();
            string sql = String.Format(@"delete from RegistroPonto where CodRegistro = {0}", id);

            using (var con = new SqlConnection(connection))
            {
                codRetorno = con.Execute(sql);
            }
            return codRetorno;
        }

        public int Edit(RegistroPonto registro)
        {
            int codRetorno = 0;
            string connection = this.GetConnection();
            string sql = String.Format(@"update RegistroPonto 
                                            set  Date                  = @Date, 
                                                 HoraEntrada           = @HoraEntrada, 
                                                 HoraSaidaAlmoco       = @HoraSaidaAlmoco, 
                                                 HoraRetornoAlmoco     = @HoraRetornoAlmoco, 
                                                 HoraSaida             = @HoraSaida, 
                                                 TotalHoras            = @TotalHoras, 
                                                 TotalHorasConvertidas = @TotalHorasConvertidas, 
                                                 DescricaoAtividades   = @DescricaoAtividades
                                          where CodRegistro = {0}", registro.CodRegistro);

            using (var con = new SqlConnection(connection))
            {
                codRetorno = con.Execute(sql, registro);
            }

            return codRetorno;
        }

        public RegistroPonto Get(int id)
        {
            string connection = this.GetConnection();
            string sql = String.Format(@"select * from RegistroPonto(nolock) where CodRegistro = {0}", id);

            using (var con = new SqlConnection(connection))
            {
                var lista = con.Query<RegistroPonto>(sql).FirstOrDefault();
                return lista;
            }


        }

        public List<RegistroPonto> GetAll()
        {
            string connection = this.GetConnection();
            string sql = @"select * from RegistroPonto(nolock)";

            using (var con = new SqlConnection(connection))
            {
                var lista = con.Query<RegistroPonto>(sql).ToList();
                return lista;
            }
        }
    }
}
