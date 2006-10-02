/**
 *   Copyright (c) Rich Hickey. All rights reserved.
 *   The use and distribution terms for this software are covered by the
 *   Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
 *   which can be found in the file CPL.TXT at the root of this distribution.
 *   By using this software in any fashion, you are agreeing to be bound by
 * 	 the terms of this license.
 *   You must not remove this notice, or any other, from this software.
 **/

using System;

namespace clojure.lang
{

public class InstanceMemberSymbol :HostSymbol, IFn {
readonly public String className;
readonly public String memberName;

public InstanceMemberSymbol(String name) : base(name) {
int lastDot = name.LastIndexOf('.');
if (lastDot == 0)
	this.className = null;
else
	this.className = name.Substring(1, lastDot-1);
this.memberName = name.Substring(lastDot + 1);
}

public Object invoke() /**/ {
return AFn.throwArity();
	}


public Object invoke(Object obj) //
	{

	return Reflector.invokeInstanceMember(memberName, obj);
	}

public Object invoke(Object obj, Object val) //
	{

	return Reflector.invokeInstanceMember(memberName, obj, val);
	}

public Object invoke(Object arg1, Object arg2, Object arg3)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10, Object arg11)
	{
	return Reflector
			.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10, Object arg11, Object arg12)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
										  arg11, arg12);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10, Object arg11, Object arg12, Object arg13)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
										  arg11, arg12, arg13);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10, Object arg11, Object arg12, Object arg13, Object arg14)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
										  arg11, arg12, arg13, arg14);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10, Object arg11, Object arg12, Object arg13, Object arg14,
					 Object arg15)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
										  arg11, arg12, arg13, arg14, arg15);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10, Object arg11, Object arg12, Object arg13, Object arg14,
					 Object arg15, Object arg16)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
										  arg11, arg12, arg13, arg14, arg15, arg16);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10, Object arg11, Object arg12, Object arg13, Object arg14,
					 Object arg15, Object arg16, Object arg17)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
										  arg11, arg12, arg13, arg14, arg15, arg16, arg17);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10, Object arg11, Object arg12, Object arg13, Object arg14,
					 Object arg15, Object arg16, Object arg17, Object arg18)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
										  arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10, Object arg11, Object arg12, Object arg13, Object arg14,
					 Object arg15, Object arg16, Object arg17, Object arg18, Object arg19)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
										  arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
	}

public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10, Object arg11, Object arg12, Object arg13, Object arg14,
					 Object arg15, Object arg16, Object arg17, Object arg18, Object arg19, Object arg20)
	{
	return Reflector.invokeInstanceMember(memberName, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
										  arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20);
	}


public Object invoke(Object arg1, Object arg2, Object arg3, Object arg4, Object arg5, Object arg6, Object arg7,
					 Object arg8, Object arg9, Object arg10, Object arg11, Object arg12, Object arg13, Object arg14,
					 Object arg15, Object arg16, Object arg17, Object arg18, Object arg19, Object arg20
		, params Object[] args)
	{
	throw new InvalidOperationException("Can't call functions of more than 20 arguments");
	}


public Object applyTo(ISeq arglist) /**/ {
return AFn.applyToHelper(this, arglist);
	}
	
}

}