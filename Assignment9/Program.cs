using Microsoft.EntityFrameworkCore;

namespace Assignment9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //��DbContext���뵽����
            builder.Services.AddDbContext<OrderContext>(opt => opt.UseMySQL(
                "Server=localhost;Database=todoDB;User=root;Password="));

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseDefaultFiles(); //����ȱʡ��̬ҳ�棨index.html��index.htm��
            app.UseStaticFiles(); //���þ�̬�ļ���ҳ�桢js��ͼƬ�ȸ���ǰ���ļ���

            app.UseHttpsRedirection(); //����http��https���ض���
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
