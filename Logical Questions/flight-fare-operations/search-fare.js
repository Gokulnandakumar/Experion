const fares = [25324.50,56904.21,4563.76,34561.65,90000.21,9087,43000.98,65478.10,88888.34,67000.44,78234.88];

const serachKey = 65478.10;
var count = -1;
fares.forEach(element => {
    count++;
    if(element === serachKey){
        console.log(element + ' found at ' + count)
    }
})