using Inheritance;

Vehicle vehicle = new Vehicle(
                model: null,
                year: new DateTime(2020, 1, 1),
                color: null,
                numberOfWheel: 0,
                kilometer: 0,
                topSpeed: 0,
                currentSpeed: 0);

Car car = new Car(model: "Toyota Corolla",
                year: new DateTime(2020, 1, 1),
                color: "Blue",
                numberOfWheel: 4,
                kilometer: 25000.5,
                topSpeed: 180.0,
                currentSpeed: 0.0,
                numberOfDoor: 4);


Bike bike = new Bike(model: "Yamaha",
                year: new DateTime(2020, 1, 1),
                color: "Blue",
                numberOfWheel: 4,
                kilometer: 25000.5,
                topSpeed: 180.0,
                currentSpeed: 0.0);

vehicle.StartEngine();
vehicle.StopEngine();
vehicle.IncreaseSpeed();


car.StartEngine();
car.StopEngine();
car.IncreaseSpeed();

bike.StartEngine();
bike.StopEngine();
bike.IncreaseSpeed();