--
-- PostgreSQL database dump
--

-- Dumped from database version 15.1 (Debian 15.1-1.pgdg110+1)
-- Dumped by pg_dump version 15.1 (Debian 15.1-1.pgdg110+1)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: cliente; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.cliente (
    clienteid integer NOT NULL,
    nomecliente character varying(80),
    responsavelcliente character varying(80),
    cnpj character(14) NOT NULL,
    "endereço" character varying(120),
    cpf character(14),
    telefone character(14),
    email character(60)
);


--
-- Name: demo; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.demo (
    id integer NOT NULL,
    name character varying(200) DEFAULT ''::character varying NOT NULL,
    hint text DEFAULT ''::text NOT NULL
);


--
-- Name: demo_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.demo_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- Name: demo_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.demo_id_seq OWNED BY public.demo.id;


--
-- Name: fornecedor; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.fornecedor (
    fornecedorid integer NOT NULL,
    cnpj character(18),
    contadorvendas integer,
    nomeempresa character varying(80),
    nomeresponsavel character varying(80),
    "endereço" character varying(120),
    cpf character(14),
    telefone character(14),
    email character(60)
);


--
-- Name: negociacao; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.negociacao (
    negociacaoid integer NOT NULL,
    fornecedorid integer,
    clienteid integer,
    status character varying(15),
    datanegociacao date
);


--
-- Name: produto; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.produto (
    produtoid integer NOT NULL,
    nomeproduto character varying(30) NOT NULL,
    valorunitario numeric,
    quantidadeproduto integer,
    descricaoproduto character varying(100)
);


--
-- Name: demo id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.demo ALTER COLUMN id SET DEFAULT nextval('public.demo_id_seq'::regclass);


--
-- Name: cliente cliente_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_pkey PRIMARY KEY (clienteid);


--
-- Name: demo demo_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.demo
    ADD CONSTRAINT demo_pkey PRIMARY KEY (id);


--
-- Name: fornecedor fornecedor_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.fornecedor
    ADD CONSTRAINT fornecedor_pkey PRIMARY KEY (fornecedorid);


--
-- Name: negociacao negociacao_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.negociacao
    ADD CONSTRAINT negociacao_pkey PRIMARY KEY (negociacaoid);


--
-- Name: produto produto_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.produto
    ADD CONSTRAINT produto_pkey PRIMARY KEY (produtoid);


--
-- Name: negociacao negociacao_clienteid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.negociacao
    ADD CONSTRAINT negociacao_clienteid_fkey FOREIGN KEY (clienteid) REFERENCES public.cliente(clienteid);


--
-- Name: negociacao negociacao_fornecedorid_fkey; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.negociacao
    ADD CONSTRAINT negociacao_fornecedorid_fkey FOREIGN KEY (fornecedorid) REFERENCES public.fornecedor(fornecedorid);


--
-- PostgreSQL database dump complete
--

