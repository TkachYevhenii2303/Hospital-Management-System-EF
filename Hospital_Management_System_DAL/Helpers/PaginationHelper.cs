using Hospital_Management_System_DAL.Filter;
using Hospital_Management_System_DAL.Pagination;
using Hospital_Management_System_DAL.Pagination.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Helpers
{
    public class PaginationHelper
    {
        public static PagedResponse<IEnumerable<TEntity>> CreatePagedReponse<TEntity>(IEnumerable<TEntity> pagedData, PaginationFiltering validFilter, int totalRecords, IUriService uriService, string route)
        {
            var respose = new PagedResponse<IEnumerable<TEntity>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            
            respose.NextPage =
                validFilter.PageNumber >= 1 && validFilter.PageNumber < roundedTotalPages
                ? uriService.GetPageUri(new PaginationFiltering(validFilter.PageNumber + 1, validFilter.PageSize), route)
                : null;
            
            respose.PreviousPage =
                validFilter.PageNumber - 1 >= 1 && validFilter.PageNumber <= roundedTotalPages
                ? uriService.GetPageUri(new PaginationFiltering(validFilter.PageNumber - 1, validFilter.PageSize), route)
                : null;
            
            respose.FirstPage = uriService.GetPageUri(new PaginationFiltering(1, validFilter.PageSize), route);

            respose.LastPage = uriService.GetPageUri(new PaginationFiltering(roundedTotalPages, validFilter.PageSize), route);
            
            respose.TotalPages = roundedTotalPages;
            
            respose.TotalRecords = totalRecords;

            return respose;
        }
    }
}
