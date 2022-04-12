using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PhieuMuon
    {
        [Column("PhieuMuonId")]
        public Guid Id { get; set; }
        [ForeignKey(nameof(DocGia))]
        public Guid DocGiaId { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayHetHan { get; set; }
        public DocGia DocGia { get; set; }
        public IEnumerable<ChiTietPhieuMuon> CTPhieuMuons { get; set; }
    }
}
