using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ChiTietPhieuMuon
    {
        [Column("ChiTietPhieuMuonId")]
        public Guid Id { get; set; }
        [ForeignKey(nameof(PhieuMuon))]
        public Guid PhieuMuonId { get; set; }
        [ForeignKey(nameof(Sach))]
        public Guid SachId { get; set; }
        public Sach Sach { get; set; }
    }
}
