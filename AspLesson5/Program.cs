//«адание
//—оздайте MVC приложение форму, на которой будет находитьс€ два пол€ ввода,
//одно поле ввода дл€ значени€, а второе поле ввода дл€ установки даты и времени
//(можете использовать HTML элемент управлени€) и кнопка, котора€ отправит данные на сервер.
//Ќа сервере полученна€ информаци€ должна быть записана в Cookies с установкой даты устаревани€ равной той,
//котора€ была установлена во втором поле ввода в форме. —делайте страницу,
//котора€ будет использоватьс€ дл€ проверки наличи€ значени€ в Cookies

//«адание 1
//—оздайте MVC приложение, которое будет подсчитывать количество пользователей онлайн.
// оличество пользователей должно отображатьс€ на странице вашего приложени€.
//ƒл€ проверки работы приложени€, запустите его в несколько браузерах.
//≈сли вы откроете приложение в трех браузерах, количество пользователей онлайн должно быть равное трем.
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