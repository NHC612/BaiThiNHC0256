using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaiThiNHC.Models;
public class NHCcau3
{
    [Key]
    public string MaSinhVien {get; set;}
    public string TenSinhVien {get; set;}
    public string Address {get; set;}
}
