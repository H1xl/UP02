# Запуск проекта
* Распаковать архив проекта
* Перейти по пути
	```
	Место распаковки\Learn\Learn\bin\Release	
	```
* Запустить файл Learn.exe
* Удостовериться в работоспосбости приложения

# Необходимые условия
### Системные требования
* ОС: Windows 10/11 x64
* Процессор: Intel Celeron G4900
* ОЗУ: 4Гб

### Библиотеки
```
.NET v4.8+
Windows Forms
MSSQLLocalDB Entity Framework
```

# Предметная область
### Описание
Школа языков “Леарн” открывает большое количество дополнительных направлений в рамках оказаний услуг (например: подготовка к ЕГЭ, тренировки к TOEFL, выездные кемпинги в другие страны и много другое). В связи с этим нам важно, чтобы родители слушателей, а также наши взрослые слушатели могли ознакомиться со списком абсолютно всех услуг на наших компьютерах, пока они ждут преподавателя на очередное занятие.  

![image](school_logo.png)

### Требования 
Разработана система для работы с услугами компании, которая включает в себя следующий функционал: 
* просмотр списка услуг, 
* добавление/удаление/редактирование данных об услугах, 
* работа с дополнительными изображениями к услугам, 
* запись клиента на услугу, 
* управление ближайшими записями на услуги школы иностранных языков. 

#### Структура проекта 
Каждая сущность представлена в программе как минимум одним отдельным классом. Классы небольшимие, понятные и выполняют одну единственную функцию (Single responsibility principle). 

#### Логическая структура
Данную система разделена на несколько подсистем: 
* подсистема по работе с клиентами, 
* подсистема по работе с сотрудниками, 
* подсистема по работе с товарами, 
* подсистема по работе с услугами, • подсистема для управления компанией. 

#### Стиль
Визуальные компоненты соответствуют руководству по стилю, предоставленному в качестве ресурсов к заданию в соответствующем файле. Обеспечено соблюдение требований всех компонентов.
