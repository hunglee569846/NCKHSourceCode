using EduSoft.core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EduSoft.core.Domain.IServices
{
   public interface IBoMonService
    {
        Task<List<BoMonSearchViewModel>> SelecAllAsync();
    }
}
