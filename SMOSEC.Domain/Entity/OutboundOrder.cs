using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOSEC.Domain.Entity
{
    /// <summary>
    /// 出库单
    /// </summary>
    public class OutboundOrder : IAggregateRoot
    {
        /// <summary>
        /// 出库单号
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("出库单号")]
        public string OOID { get; set; }

        /// <summary>
        /// 区域编号
        /// </summary>
        [Required]
        [DisplayName("区域编号")]
        public string LOCATIONID { get; set; }

        /// <summary>
        /// 出库类型(0 退货,1 领用)
        /// </summary>
        [Required]
        [DisplayName("出库类型")]
        public int TYPE { get; set; }

        /// <summary>
        /// 业务日期
        /// </summary>
        [Required]
        [DisplayName("业务日期")]
        public DateTime BUSINESSDATE { get; set; }

        /// <summary>
        /// 处理人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("处理人")]
        public string HANDLEMAN { get; set; }

        /// <summary>
        /// 处理日期
        /// </summary>
        [Required]
        [DisplayName("处理日期")]
        public DateTime HANDLEDATE { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("备注")]
        public string NOTE { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        [DisplayName("创建时间")]
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Required]
        [DisplayName("修改时间")]
        public DateTime MODIFYDATE { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("修改者")]
        public string MODIFYUSER { get; set; }
    }
}