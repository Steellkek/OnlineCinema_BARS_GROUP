//живой поиск
window.onload=() =>{
    let input= document.querySelector('#input')
    input.oninput=function (){
        let value = this.value.trim();
        let list = document.querySelectorAll(".col-3")
        if(value){
            list.forEach(elem=>{
                if(elem.getElementsByTagName('h4')[0].innerText.toLowerCase().search(value) ===-1){
                    elem.classList.add('hide')
                    elem.getElementsByTagName('h4')[0].innerHTML=elem.getElementsByTagName('h4')[0].innerText;
                }
                else{
                    elem.classList.remove('hide')
                    let str = elem.getElementsByTagName('h4')[0].innerText;
                    elem.getElementsByTagName('h4')[0].innerHTML=InsertMark(str, elem.innerText.search(value),value.length)
                }
            });
        }else
        {
            list.forEach(elem=>{
                elem.classList.remove('hide')
                elem.getElementsByTagName('h4')[0].innerHTML=elem.getElementsByTagName('h4')[0].innerText;
            })
        }

    }
}

function InsertMark(string, pos, len){
    return string.slice(0, pos) + `<mark>`+string.slice(pos,pos+len)+`</mark>`+string.slice(pos+len)
}

