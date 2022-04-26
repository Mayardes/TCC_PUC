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

const TBody = () => {
    return (<tbody>
        <tr>
            <td>Oliveira</td>
            <td>React</td>
            <td>1500</td>
            <td><button>Remover</button></td>
        </tr>
        <tr>
            <td>Oliveira</td>
            <td>React</td>
            <td>1500</td>
            <td><button>Remover</button></td>
        </tr>
    </tbody>);
}


class Tabela extends Component {
    render() {
        return (<table>
            <THead/>
            <TBody/>
        </table>);
    }
}
export default Tabela;