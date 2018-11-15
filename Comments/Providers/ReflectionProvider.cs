using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;

namespace Comments.Providers {
    public class ReflectionProvider {
        protected static ReflectionProvider instance;

        /**
         * Chiama per reflection un metodo
         */
        public object callMetodoByName(string nomeDll, string nomeClasse, string nomeMetodo, params object[] paramList) {
            ObjectHandle handle;

            handle = Activator.CreateInstance(
                nomeDll,
                String.Format("{0}.{1}", nomeDll, nomeClasse)
                );

            var unwrapped = handle.Unwrap();
            return Interaction.CallByName(unwrapped, nomeMetodo, CallType.Method, paramList);
        }

        protected ReflectionProvider() {
        }

        public static ReflectionProvider getInstance() {
            if (instance == null) instance = new ReflectionProvider();
            return instance;
        }
    }
}