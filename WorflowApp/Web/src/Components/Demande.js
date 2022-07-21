import React,{Component} from 'react';
import {Table} from 'react-bootstrap';
import {Button,ButtonToolbar} from 'react-bootstrap';
import {AddDemande} from './AddDemande';

export class Demande extends Component{

    constructor(props){
        super(props);
        this.state={demds:[], addModalShow:false}
    }

    refreshList(){
        fetch(process.env.REACT_APP_API+'demandes')
        .then(response=>response.json())
        .then(data=>{
            this.setState({demds:data});
        });
    }

    componentDidMount(){
        this.refreshList();
    }

    componentDidUpdate(){
        this.refreshList();
    }

    render(){
        const {demds}=this.state;
        let addModalClose=()=>this.setState({addModalShow:false});
        return(
            <div >
                <Table className="mt-4" striped bordered hover size="sm">
                    <thead>
                        <tr>
                            <th>Number</th>
                            <th>Title</th>
                            <th>Comment</th>
                            <th>Deadline</th>
                            {/* <th>Type demande</th> */}
                            <th>Options</th>
                        </tr>
                    </thead>
                    <tbody>
                        {demds.map(dep=>
                            <tr key={dep.id}>
                                <td>{dep.number}</td>
                                <td>{dep.title}</td>
                                <td>{dep.comment}</td>
                                <td>{dep.deadline}</td>
                                {/* <td>{dep.TypeDEmandeTypeId}</td> */}
                                <td>Edit /Delete</td>
                            </tr>)}
                    </tbody>

                </Table>
                <ButtonToolbar>
                    <Button variant='primary'
                    onClick={()=>this.setState({addModalShow:true})}>
                    Add Demande</Button>

                    <AddDemande show={this.state.addModalShow}
                    onHide={addModalClose}/>
                </ButtonToolbar>
            </div>
        )
    }
}