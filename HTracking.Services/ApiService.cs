using System;
using System.Collections.Generic;
using HTracking.Data;
using HTracking.Models;

namespace HTracking.Services
{
    public interface IApiService 
    {
        IList<T> GetForms<T>() where T : BaseForm;
        void SubmitForm<T>(T form) where T : BaseForm;
    }

    public class ApiService : IApiService
    {
        readonly IDataService _dataService;

        public ApiService(IDataService dataService)
        {
            _dataService = dataService;
        }

        public IList<T> GetForms<T>() where T : BaseForm
        {
            return _dataService.GetForms<T>();
        }

        public void SubmitForm<T>(T form) where T : BaseForm
        {
            _dataService.SubmitForm<T>(form);
        }
    }
}
