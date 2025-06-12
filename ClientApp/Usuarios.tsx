const Usuarios = ()=> {
    return (
        <>
        <div className="container">
            <h1>Usuarios</h1>
        </div>
            <div className="container"> 
                <div className="card">  
                 <div className="car body">
                    <div className="row">
                        <div className="col-12">
                            <div className="mb-3">
                                <label > Busqueda de Usuarios</label>
                                <input type="text" className="form-control" placeholder="Introduce el nombre o el correo"/>
                            </div>
                            <div className="cold-12">
                                <button className="btn btn-primary">Buscar</button>
                            </div>
                        </div>
                    </div>
                 </div>
                </div>  
          </div>

          <div className="container">
            <div className="card">
                <div className="card-header"> Usuarios existentes</div>
                <div className="card-body">
                    <table className="table table-stripe">
                        <thead>
                            <tr>
                                <th>No.</th>
                                <th>Nombre</th>
                                <th>Correo</th>
                                <th>Password</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>  
                                <td>1</td>
                                <td>Nombre del usuario 1 </td>
                                <td>Correo del usuario 1 </td>
                                <td></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
          </div>
    
        </>
    )
       
    
}

export default Usuarios; 