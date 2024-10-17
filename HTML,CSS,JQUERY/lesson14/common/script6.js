let text;
switch(new Date().getDay()){
    case 6:
        text="Sartuday";
        break;
    case 0:
        text="Sunday";
        break
    default:
        text="Tôi Không biết:))"
    break;            
}
document.getElementById("demo").innerHTML=text;