# TamagochiApp
 Необходимо разработать консольное приложение на языке C#, реализующее простейшую логику электронной игры "Тамагочи".

Обязательные требования к разрабатываемому приложению:
  1.	Должна быть возможность ввести имя питомца.
  2.	Питомец должен обладать следующими свойствами (показателями): <br>
      1.	уровень здоровья (минимальное значение = 0, максимальное значение = 10, начальное значение = 10);<br>
      2.	уровень голода (минимальное значение = 0, максимальное значение = 10, начальное значение = 0);<br>
      3.	уровень усталости (минимальное значение = 0, максимальное значение = 10, начальное значение = 0).
      
  4.	В приложении, с помощью меню, должны быть доступны следующие действия:<br>
      1.	покормить;<br>
      2.	поиграть;<br>
      3.	укачать (сон).
  6.	Действия (перечислены в пункте 2), должны влиять на показатели (перечислены в пункте 1) следующим образом:<br> 
      1.	кормление - понижает уровень голода. При избыточном кормлении (переедание) понижается показатель здоровья на 1 пункт.<br>
      2.	игра - повышает уровень усталости. При избыточной игре понижается показатель здоровья на 1 пункт, а показатель голода увеличивается на 1 пункт.<br>
      3.	укачивание (сон) - снижает полностью уровень усталости, восстанавливает 1 пункт здоровья, увеличивает показатель голода на 1 пункт.<br>
      4.	Критическим считается уровень здоровья = 0, при котором питомец заболевает и игра завершается.

Дополнительные требования к разрабатываемому приложению (на усмотрение разработчика):
  •	Реализовать дополнительные действия. Например: лечение.
  •	Реализовать дополнительные показатели питомца. Например: уровень счастья.
  •	Зависимость дополнительных показателей и действий.
  •	Формат вывода информации в окно терминала.

