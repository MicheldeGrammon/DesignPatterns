
# Builder (Строитель)

## Назначение
Инкапсулирует создание объекта и позволяет разделить его на различные этапы. Отделяет конструирование сложного объекта от его представления, так что 
в результате одного и того же процесса конструирования могут получаться 
разные представления.

## Когда надо применять паттерн:
* Когда необходимы различные варианты представления объекта

## Условие для использования
* Алгоритм создания объекта НЕ ЗАВИСИТ от  частей объкта и их состыковки

## Дополнительно

Очень похож на Factory Method. Отличают по своим целям, задачам и реализации. Билдер акцентирует на создании частей объекта, а абстратнаяя файбрика - на оздание взаимосвязанных объектов.