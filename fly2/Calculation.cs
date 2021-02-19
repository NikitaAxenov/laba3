using System;

namespace fly2
{
    public class Calculation
    {
        public decimal t, x, y, v0, cosa, sina, S, m, k, vx, vy;
        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;
        const decimal dt = 0.1M;

        public Calculation()
        {
            t = 0;
            x = 0;
        }

        public void ForBtn()
        {
            k = 0.5M * C * rho * S / m;
            vx = v0 * cosa;
            vy = v0 * sina;
        }

        public void ForTimer()
        {
            t += dt;
            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
        }
    }
}
