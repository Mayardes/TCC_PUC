import logo from './logo.svg';
import './App.css';
import Tabela from './Components/Tabela';

function App() {

  const autores = [
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
  return (
    <div className="App">
      <Tabela autores = {autores}/>
    </div>
  );
}

export default App;
