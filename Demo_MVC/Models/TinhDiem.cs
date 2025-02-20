namespace Demo_MVC.Models
{
    public class TinhDiem
    {
        private double _diemA;
        private double _diemB;
        private double _diemC;

        public double DiemA
        {
            get => _diemA;
            set => _diemA = Math.Clamp(value, 0, 10); // Giới hạn từ 0 đến 10
        }

        public double DiemB
        {
            get => _diemB;
            set => _diemB = Math.Clamp(value, 0, 10);
        }

        public double DiemC
        {
            get => _diemC;
            set => _diemC = Math.Clamp(value, 0, 10);
        }
    }
}
