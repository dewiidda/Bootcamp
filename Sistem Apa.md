``` mermaid
classDiagram
    class Animal {
        -int sizeInFeet
        -canEat()
    }
    class Cat{
        -species
        +Meow()
    }
    Animal <|-- Cat


```