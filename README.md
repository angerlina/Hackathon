# Hackathon SberTech 2016
Реализация REST-микросервисов генерации случайных тестовых данных.

Реализованы следующие сервисы:
* Генерация ИНН для юридических и физических лиц
* Генерация ОГРН для юридических лиц и ИП
* Генерация КПП
* Генерация СНИЛС
* Генерация кадастрового номера
* Генерация пола
* Генерация наименования органа, выдавшим паспорт
* Генерация номера банковской карты
* Генерация CVV кода
* Генерация Email
* Генерация типа населеного пункта
* Генерация типа улицы
* Генерация воинского звания

Доступ к сервисам достигается по http-протоколу по определенным ссылкам.

На данный момент доступ к сервисам возможен только локально с веб-сервером приложений.

###Генерация номера ИНН
Для юридических лиц http://{host}:{port}/InnGeneratorService.svc/Generate/entity

Для физических лиц http://{host}:{port}/InnGeneratorService.svc/Generate/individual

###Генерация ОГРН
Для юридических лиц http://{host}:{port}/OGRNGeneratorService.svc/Generate/1

Для ИП http://{host}:{port}/OGRNGeneratorService.svc/Generate/2

###Генерация КПП
http://{host}:{port}/OGRNGeneratorService.svc/Generate/

Вывод случайного кода причины постановки на учет

###Генерация СНИЛС
http://{host}:{port}/SnilsGeneratorService.svc/Generate/

Вывод случайного валидного страхового номера индивидуального лицевого счёта

###Генерация кадастрового номера
http://{host}:{port}/CadastreGeneratorService.svc/Generate/

Вывод случайного кадастрового номера

###Генерация пола
http://{host}:{port}/SexGeneratorService.svc/Generate/{LanguageCode}

В качестве параметра указывается строка с кодом языка (ru, en, de, fr, ch), а в ответе приходит строка
с наименованием пола на выбранном языке.

###Генерация строки с наименованием органа, выдавшим паспорт
http://{host}:{port}/WhomPassportIssuedGeneratorService.svc/Generate/

Вывод случайного наименования органа, выдавшим паспорт

###Генерация номера банковской карты
http://{host}:{port}/CreditCardNumberGeneratorService.svc/Generate/

Вывод случайного валидного номера кредитной карты

###Генерация CVV кода
http://{host}:{port}/CvvGeneratorService.svc/Generate/

Вывод случайного CVV-кода

###Генерация Email по домену
http://{host}:{port}/EmailGeneratorService.svc/Generate/{domain}

Вывод случайного email адреса. Параметр указывается в виде домена второго уровня.

###Генерация типа населенного пункта
http://{host}:{port}/LocalityTypeGeneratorService.svc/Generate/

Вывод случайного типа населенного пункта

###Генерация типа улицы
http://{host}:{port}/StreetTypeGeneratorService.svc/Generate/

Вывод случайного типа улицы

###Генерация воинского звания
http://{host}:{port}/RankGeneratorService.svc/Generate/

Вывод случайного воинского звания








