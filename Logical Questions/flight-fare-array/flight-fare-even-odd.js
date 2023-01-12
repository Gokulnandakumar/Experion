const fares = [25324.50,56904.21,4563.76,34561.65,90000.21,9087,43000.98,65478.10,88888.34,67000.44,78234.88];

let EvenArray = [];

fares.forEach(Element => {
    EvenArray.push(' ');
    EvenArray.push(Element);
})

EvenArray.forEach(Element => {
    console.log(Element);
})