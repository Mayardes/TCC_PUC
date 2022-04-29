import logo from './logo.svg';
import './App.css';
import Tabela from './Components/Tabela';
import { Component } from 'react';
import Formulario from './Components/Formulario';
import {Fragment} from 'react';

class App extends Component {

  state = {
    autores: [
      {
        nome: "Robert Cecil",
        livro: "Clean Code",
        preco: 95.00
      },
      {
        nome: "Eric Evans",
        livro: "Domain Driven Design",
        preco: 79.00
      },
      {
        nome: "Kent Beck",
        livro: "Test-Driven Develpment",
        preco: 95.00
      }
    ]
  }

  removeAutor = (element) => {
    const { autores } = this.state;

    this.setState({
      autores: autores.filter((autor, posA) => {
        return posA !== element;
      })
    });
  }


  render() {
    return (
      <Fragment>
        <Tabela autores={this.state.autores} removeAutor={this.removeAutor} />
        <Formulario />
      </Fragment>
    );
  }
}

export default App;
