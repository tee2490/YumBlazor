namespace YumBlazor.Data
{
    public class OrderHeader
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "Order Total")]
        public double OrderTotal { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public string Status { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        public string? SessionId { get; set; }
        public string? PaymentIntentId { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    }
}

//Session ID คือ หมายเลขประจำตัว ที่ Web Server ส่งมายัง Client
//ค่า Session จะไม่มีทางซ้ำกัน Session ID มีประโยชน์ในการอ้างอิงเกี่ยวกับการใช้งานของ Client