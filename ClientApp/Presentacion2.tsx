import {useEffect, useState}from "react";

type Equipo = {
     "Id": string,
    "Escuela": string,
    "Carrera": string,
    "Grupo":string,
    "DatosSemestre":string, 
    "Proyecto": string,
    "Integrante1": string,
    "Integrante2": string,
    "Fecha": string
}

const Presentacion2 =  () => {
 const [equipo, setEquipo] = useState<Equipo>();
    //Manejo de datos
const cargarDatos =  async ()=> {
    const resp = await fetch("/mi-proyecto/presentacion"); 
    if(resp.ok){
        const datos = await resp.json(); 
        console.log(datos);
        setEquipo(datos);
    }
}

    useEffect(()=>{
        cargarDatos();
    }, []); 

    return(
        <>
            <div className="display-4 text-center">{equipo?.Escuela}</div>
            <div className="h1 text-center mt-4">{equipo?.Carrera}</div>
            <div className="h1 text-center mt-4">{equipo?.DatosSemestre}</div>
            <div className="h1 text-center">{equipo?.Grupo}</div>
            <div className="h1 text-center mt-4">Integrantes</div>
            <div className="h2 text-center">{equipo?.Integrante1}</div>
            <div className="h2 text-center">{equipo?.Integrante2}</div>
            <div className="h1 text-center mt-4">Nombre del Proyecto</div>
            <div className="h2 text-center">{equipo?.Proyecto}</div>
            <div className="h4 text-center mt-4">{equipo?.Fecha}</div>
        </>
    )
}

export default Presentacion2;