const fares = [25324.50,56904.21,4563.76,34561.65,90000.21,9087,43000.98,65478.10,88888.34,67000.44,78234.88];

function ascending(fares) {
    let swap ;
    for (let i = 0; i < fares.length; i++) {
       for (let j = 0; j < fares.length-i-1; j++) {
           if(fares[j] < fares[j+1]) 
           {
             swap =  fares[j];
             fares[j] = fares[j+1];
             fares[j+1] = swap;
           }
       } 
    //    console.log(swap); 
    }
    console.log(fares);
}


ascending(fares);
// for (let index = 0; index < passengers.length; index++) {
//     console.log(duplicate[index]);
// }



