const passengers_name = prompt("enter a passenger name");
const passenger_miles = prompt("enter passenger miles")

function Calculate(name, miles) {
    if (miles > 10000 && miles < 20000) {
        console.log(name);
        document.write(name, '10');
    } else if (miles > 20000 && miles < 50000) {
        console.log(name);
        document.write(name, '20');
    } else if (miles > 50000 && miles < 100000) {
        console.log(name);
        document.write(name, '30');
    } else if (miles > 100000) {
        console.log(name);
        document.write(name, '50');
    }
}

Calculate(passengers_name, passenger_miles);
