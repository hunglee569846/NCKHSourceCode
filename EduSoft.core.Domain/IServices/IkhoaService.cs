using EduSoft.core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EduSoft.core.Domain.IServices
{
  public interface IkhoaService
    {
        Task<List<KhoaViewModel>> SelecAllAsync();
    }
}
