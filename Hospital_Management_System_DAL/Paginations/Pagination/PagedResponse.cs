using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Pagination
{
    public class PagedResponse<TEntity> : Response<TEntity>
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }
        
        public Uri? FirstPage { get; set; }
        
        public Uri? LastPage { get; set; }
        
        public int TotalPages { get; set; }
        
        public int TotalRecords { get; set; }

        public Uri? NextPage { get; set; }
        
        public Uri? PreviousPage { get; set; }

        public PagedResponse(TEntity result, int pageNumber, int pageSize) 
        {
            this.PageNumber = pageNumber;
            
            this.PageSize = pageSize;
            
            this.Result = result;
        }
    }
}
