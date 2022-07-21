import React,{Component} from 'react';
import {Modal,Button, Row, Col, Form} from 'react-bootstrap';

export class EditDemande extends Component{
    constructor(props){
        super(props);
        this.handleSubmit=this.handleSubmit.bind(this);
    }

    handleSubmit(event){
        event.preventDefault();
        fetch(process.env.REACT_APP_API+'demandes',{
            method:'PUT',
            headers:{
                'Accept':'application/json',
                'Content-Type':'application/json'
            },
            body:JSON.stringify({
                number:event.target.number.value,
                title:event.target.title.value,
                Comment: event.target.Comment.value,
                deadline: event.target.deadline.value
            })
        })
        .then(res=>res.json())
        .then((result)=>{
            alert(result);
        },
        (error)=>{
            alert('Failed');
        })
    }
    render(){
        return (
            <div className="container">

<Modal
{...this.props}
size="lg"
aria-labelledby="contained-modal-title-vcenter"
centered
>
    <Modal.Header clooseButton>
        <Modal.Title id="contained-modal-title-vcenter">
            Edit Demande
        </Modal.Title>
    </Modal.Header>
    <Modal.Body>

        <Row>
            <Col sm={6}>
                <Form onSubmit={this.handleSubmit}>
                <Form.Group controlId="Number">
                        <Form.Label>id</Form.Label>
                        <Form.Control type="text" name="id" 
                        disabled
                        defaultValue={this.props.id} 
                        placeholder="id"/>
                    </Form.Group>
                <Form.Group controlId="Number">
                        <Form.Label>Number</Form.Label>
                        <Form.Control type="text" name="Number" required
                        defaultValue={this.props.number} 
                        placeholder="Number"/>
                    </Form.Group>

                    <Form.Group controlId="title">
                        <Form.Label>title</Form.Label>
                        <Form.Control type="text" name="title" required 
                        defaultValue={this.props.title}
                        placeholder="title"/>
                    </Form.Group>

                    <Form.Group controlId="comment">
                        <Form.Label>comment</Form.Label>
                        <Form.Control type="text" name="comment" required 
                        defaultValue={this.props.comment}
                        placeholder="comment"/>
                    </Form.Group>

                    <Form.Group controlId="deadline">
                        <Form.Label>deadline</Form.Label>n
                        <Form.Control type="text" name="deadline" required 
                        defaultValue={this.props.deadline}
                        placeholder="deadline"/>
                    </Form.Group>

                    <Form.Group>
                        <Button variant="primary" type="submit">
                            Update Department
                        </Button>
                    </Form.Group>
                </Form>
            </Col>
        </Row>
    </Modal.Body>
    
    <Modal.Footer>
        <Button variant="danger" onClick={this.props.onHide}>Close</Button>
    </Modal.Footer>

</Modal>

            </div>
        )
    }

}