//�������
//�������� MVC ���������� �����, �� ������� ����� ���������� ��� ���� �����,
//���� ���� ����� ��� ��������, � ������ ���� ����� ��� ��������� ���� � �������
//(������ ������������ HTML ������� ����������) � ������, ������� �������� ������ �� ������.
//�� ������� ���������� ���������� ������ ���� �������� � Cookies � ���������� ���� ����������� ������ ���,
//������� ���� ����������� �� ������ ���� ����� � �����. �������� ��������,
//������� ����� �������������� ��� �������� ������� �������� � Cookies

//������� 1
//�������� MVC ����������, ������� ����� ������������ ���������� ������������� ������.
//���������� ������������� ������ ������������ �� �������� ������ ����������.
//��� �������� ������ ����������, ��������� ��� � ��������� ���������.
//���� �� �������� ���������� � ���� ���������, ���������� ������������� ������ ������ ���� ������ ����.
namespace AspLesson5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMemoryCache();
            builder.Services.AddSession();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{Controller=counter}/{action=count}");
            });
            app.Run();
        }
    }
}