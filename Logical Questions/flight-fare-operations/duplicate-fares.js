const fares = [25324.50,56904.21,4563.76,34561.65,90000.21,4563.76,9087,43000.98,65478.10,88888.34,78234.88];

for (let i = 0; i < fares.length; i++) {
    for (let j = i+1; j < fares.length; j++) {
        if(fares[i] === fares[j]) {
            console.log(fares[i] +' ' + 'duplicate found at position' + ' ' + j);
        }
    }
   
}