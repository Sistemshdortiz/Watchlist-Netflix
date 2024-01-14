
<template>
    <header>
        <nav>
            <ul>
                <li><router-link to="/">Inicio</router-link></li>
                <li><router-link to="/acerca">Acerca de</router-link></li>
                <li><router-link to="/contacto">Contacto</router-link></li>
            </ul>
        </nav>
    </header>
</template>

<script>
    export default {
        name: 'Header',
    };
</script>

<style scoped>
    /* Estilos específicos para el componente Header */
    header {
        background-color: #333;
        color: #fff;
        padding: 1rem;
    }

    nav ul {
        list-style-type: none;
        display: flex;
    }

    nav li {
        margin-right: 1rem;
    }

    nav a {
        text-decoration: none;
        color: #fff;
        font-weight: bold;
        font-size: 1.2rem;
    }
</style>