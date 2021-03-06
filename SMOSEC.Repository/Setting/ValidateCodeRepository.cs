using SMOSEC.Domain.Entity;
using SMOSEC.Domain.IRepository;
using SMOSEC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOSEC.Repository.Setting
{
    /// <summary>
    /// 验证表的仓储实现，仅用于查询
    /// </summary>
    public class ValidateCodeRepository : BaseRepository<ValidateCode>, IValidateCodeRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ValidateCodeRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据电话号码和验证码查询信息
        /// </summary>
        /// <param name="PhoneNumber"></param>
        /// <param name="VCode"></param>
        /// <returns></returns>
        public IQueryable<ValidateCode> GetByPhone(string PhoneNumber, string VCode)
        {
            return _entities.Where(x=>x.PHONENUMBER==PhoneNumber && x.VCODE==VCode);
        }
    }
}
