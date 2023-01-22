
const userInput = prompt();
console.log(userInput);
const fares = [25324.50,56904.21,4563.76,34561.65,90000.21,4563.76,9087,43000.98,65478.10,88888.34];
const destination = ['kochi', 'Trivandrum', 'bangalore', 'dubai', 'london', 'africa', 'abu dhabi', 'san-fransisco', 'leh', 'mumbai']


if(userInput) {
    Display(destination, fares);
}

function Display(destination, fares) {
   for (let i = 0; i < destination.length; i++) {
      document.write(destination[i]  ," ", fares[i]);
      document.write("<br>")
      
   }
}