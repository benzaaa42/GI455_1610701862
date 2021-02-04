var websocket = require("ws")

var wsocketServer = new websocket.Server({port:58962},()=>{
    console.log("runing server")
})
var wslist = [];

wsocketServer.on("connection",(ws,rq)=>{

    console.log("client connected")

    wslist.push(ws)

    ws.on("message",(data)=>{

        
        console.log("send form client : "+ data)
        Boardcast(data)

    })

    ws.on("close",()=>{

        wslist = arrayremove(wslist, ws)
        console.log("client disconnected")

    })
})

function arrayremove(arr,value)
{
    return arr.filter((element)=>{
        return element != value;
    })
}
function Boardcast(data)
{
    for(var i = 0; i < wslist.length; i++)
    {
        wslist[i].send(data)
    }
}
