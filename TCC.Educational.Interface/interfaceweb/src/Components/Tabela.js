import React, { Component } from "react";


const THead = () => {
    return (<thead>
        <tr>
            <th>Autor</th>
            <th>Livro</th>
            <th>Preco</th>
            <th>Acao</th>
        </tr>
    </thead>);
}

const TBody = (item) => {

    const linhas = item.autores.map((linha, index) => {
        return (
            <tr key = {index} >
                <td>{linha.nome}</td>
                <td>{linha.livro}</td>
                <td>{linha.preco}</td>
                <td><button onClick = {() => {item.removeAutor(index)}}>Remover</button></td>
            </tr>
        );
    });

    return (<tbody>
        {linhas}
    </tbody>);
}


class Tabela extends Component {
    render() {

        const { autores, removeAutor } = this.props;

        return (<table>
            <THead />
            <TBody autores={autores} removeAutor = {removeAutor}/>
        </table>);
    }
}
export default Tabela;