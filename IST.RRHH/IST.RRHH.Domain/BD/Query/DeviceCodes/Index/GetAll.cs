// **********************************
// **********************************
// **********************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IST.RRHH.Model;
using IST.RRHH.Model.Common;

namespace IST.RRHH.Domain.Query.DeviceCodes.Index
{   
    

	public class GetAll
    {

		public class Result
		{
			public  string UserCode  {get;set;}
			public  string DeviceCode  {get;set;}
			public  string SubjectId  {get;set;}
			public  string ClientId  {get;set;}
			public  DateTime CreationTime  {get;set;}
			public  DateTime Expiration  {get;set;}
			public  string Data  {get;set;}
					
		}

        public class Query : IQuery<List<Result>>
        {
        		
			public Paginado QueryRequest {get; set;}
				
        }
 
        public class Handler : IQueryHandler<Query, List<Result>>
        {
            IBDContext context;
 
            public Handler(IBDContext context)
            {
                this.context = context;
            }
 
            public List<Result> Handle(Query query)
            {
				var result = new List<Result>();

                var queriedItem = context.DeviceCodes.ToList();

				var orderedResults = queriedItem.Select(c=> new Result { UserCode = c.UserCode , 
											   DeviceCode = c.DeviceCode , 
											   SubjectId = c.SubjectId , 
											   ClientId = c.ClientId , 
											   CreationTime = c.CreationTime , 
											   Expiration = c.Expiration , 
											   Data = c.Data });				

				if(query.QueryRequest != null)
				{
                    result = orderedResults.AsQueryable().GetPageItems(query.QueryRequest);
                }	
				else {
					result = orderedResults.ToList();
				}				

			    return result;							
            }
        }
    }
}


