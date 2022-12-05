// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using IST.RRHH.Domain.Utilidades;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.Sp
{

    public class GetSp_Widget_1
    {

        public class Result
        {
            public DataTable Resultado { get; set; }

        }

        public class Query : IQuery<Result>
        {
            /*
               var variables = new List<Domain.Utilidades.ParameterVariables>();
                variables.Add(new Domain.Utilidades.ParameterVariables { Tipo = ParameterVariablesTipo.Int, Variable = "FaenaId", Value = model.FaenaId.ToString() });         
                variables.Add(new Domain.Utilidades.ParameterVariables { Tipo = ParameterVariablesTipo.Varchar, Variable = "Usuario", Value = model.UserId.ToString() });         
                variables.Add(new Domain.Utilidades.ParameterVariables { Tipo = ParameterVariablesTipo.Varchar, Variable = "Rol", Value = model.Rol });
                variables.Add(new Domain.Utilidades.ParameterVariables { Tipo = ParameterVariablesTipo.DateTime, Variable = "Desde", Value = model.Desde.ToString() });
                variables.Add(new Domain.Utilidades.ParameterVariables { Tipo = ParameterVariablesTipo.DateTime, Variable = "Hasta", Value = model.Hasta.ToString() });                
                var query = this.Mediator.Query(new IST.Domain.Query.GetSp_Widget_1.Sp() { Variables = variables });
             */
            public List<ParameterVariables> Variables { get; set; }
            public Paginado QueryRequest { get; set; }

        }

        public class Handler : IQueryHandler<Query, Result>
        {
            IBDContext context;

            
            public Handler(IBDContext context)
            {
                this.context = context;
                
            }

            public Result Handle(Query query)
            {   
                var result = new Result();
                result.Resultado = LlamarSpHelper.GetResultProcedureStoreParameterReporteDinamico("Sp_Widget_1", query.Variables, this.context);
                return result;
            }
        }
    }

}


