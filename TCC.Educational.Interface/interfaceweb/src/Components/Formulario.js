import React, { Component } from 'react';

class Formulario extends Component {

    constructor(props) {
        super(props)

        this.stateInicial = { nome: '', livro: '', preco: '' }
        this.state = this.stateInicial;
    }

    escutadorDeInput = (event) => {
        //pegamos o nome do componente e seu valor
        const {name, value} = event.target;


        this.setState({
            [name]: value
        })
    }

    render() {

        const { nome, livro, preco } = this.state;
        return (
            <form>
                <label htmlFor="nome">Nome</label>
                <input id="nome" type="text" name="nome" value={nome} onChange={this.escutadorDeInput}/>

                <label htmlFor="livro">Livro</label>
                <input id="livro" type="text" name="livro" value={livro} onChange={this.escutadorDeInput}/>

                <label htmlFor="preco">Preco</label>
                <input id="preco" type="text" name="preco" value={preco} onChange={this.escutadorDeInput}/>
            </form>
        );


    }
}

export default Formulario