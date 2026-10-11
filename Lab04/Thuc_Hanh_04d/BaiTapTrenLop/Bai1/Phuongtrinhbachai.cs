namespace BaiTL1
{
    // Lớp lưu hệ số và giải phương trình. Giải được cả bậc nhất (ax + b = 0)
    // lẫn bậc hai (ax^2 + bx + c = 0), nên chỉ cần một lớp cho cả hai kiểu.
    public class PhuongTrinhBacHai
    {
        // Sai số khi so sánh số thực với 0. Với hệ số lẻ như 0.1, delta có thể ra
        // 1e-17 thay vì đúng 0, khi đó phương trình phải được coi là có nghiệm kép.
        private const double Eps = 1e-9;

        private double _a, _b, _c;

        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        public double C
        {
            get { return _c; }
            set { _c = value; }
        }

        public PhuongTrinhBacHai()
        {
            _a = _b = _c = 0;
        }

        public PhuongTrinhBacHai(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        // Delta của phương trình bậc hai
        public double Delta()
        {
            return _b * _b - 4 * _a * _c;
        }

        // Giải ax + b = 0 (chỉ dùng A và B)
        public string GiaiBacNhat()
        {
            if (Math.Abs(_a) < Eps)
            {
                // a = 0 thì còn lại 0x + b = 0: đúng với mọi x nếu b = 0, ngược lại vô nghiệm
                if (Math.Abs(_b) < Eps)
                    return "Phương trình có vô số nghiệm";
                return "Phương trình vô nghiệm";
            }

            double x = -_b / _a;
            return "Phương trình có nghiệm x = " + Dinh(x);
        }

        // Giải ax^2 + bx + c = 0. Người gọi phải bảo đảm a khác 0; nếu a = 0 thì
        // đây không còn là phương trình bậc hai nên báo lại thay vì chia cho 0.
        public string GiaiBacHai()
        {
            if (Math.Abs(_a) < Eps)
                return "Hệ số a = 0 nên đây không phải phương trình bậc hai";

            double delta = Delta();

            if (Math.Abs(delta) < Eps)
            {
                double x = -_b / (2 * _a);
                return "Phương trình có nghiệm kép x1 = x2 = " + Dinh(x);
            }
            if (delta < 0)
                return "Phương trình vô nghiệm";

            double can = Math.Sqrt(delta);
            double x1 = (-_b + can) / (2 * _a);
            double x2 = (-_b - can) / (2 * _a);
            return "Phương trình có 2 nghiệm phân biệt x1 = " + Dinh(x1) + ", x2 = " + Dinh(x2);
        }

        // Làm tròn 2 chữ số thập phân để hiển thị. Gộp luôn trường hợp -0 (vd -0/2
        // hoặc -0.001 làm tròn) về 0, nếu không sẽ in ra "-0.00".
        private static string Dinh(double x)
        {
            double r = Math.Round(x, 2);
            if (r == 0) r = 0;
            return r.ToString("0.00");
        }
    }
}